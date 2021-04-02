using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;

namespace CADPhoneCase
{
    /// <summary>
    /// Создание модели.
    /// </summary>
    public class PhoneCaseModeler
    {
        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="kompas">Интерфейс API компаса.</param>
        public PhoneCaseModeler(KompasObject kompas)
        {
            _kompas = kompas;
        }

        /// <summary>
        /// Создание модели на основе входных параметров.
        /// </summary>
        /// <param name="parameters">Размеры чехла.</param>
        public void CreateModel(PhoneCaseParameters parameters)
        {
            var centerHeight = -parameters.CaseHeight / 2 - 0.5;
            _doc3D = (ksDocument3D)_kompas.Document3D();
            _doc3D.Create();
            _doc3D = (ksDocument3D)_kompas.ActiveDocument3D();
            _part = (ksPart)_doc3D.GetPart((short)Part_Type.pTop_Part);
            CreateCaseBase(parameters.CaseLength, parameters.CaseWidth, parameters.CaseHeight);
            CreateCamHole(parameters.CameraHoleLength, parameters.CameraHoleWidth, 
                parameters.CameraRightGap, parameters.CameraTopGap);
            CreateSideButtonsHole(parameters.SideButtonsHoleWidth, parameters.SideButtonsHoleHeight, 
                centerHeight, parameters.SideButtonsGap);
            CreateMiniJackHole(parameters.MiniJackDiameter, parameters.MiniJackGap, parameters.CaseWidth,
                parameters.CaseLength, centerHeight);
            CreateChargerHole(parameters.ChargerHoleWidth, parameters.ChargerHoleHeight, parameters.CaseLength,
                parameters.CaseWidth, centerHeight);
        }
        
        /// <summary>
        /// Создание основы чехла.
        /// </summary>
        /// <param name="caseLength">Длина чехла.</param>
        /// <param name="caseWidth">Ширина чехла.</param>
        /// <param name="caseHeight">Высота чехла.</param>
        private void CreateCaseBase(double caseLength, double caseWidth, double caseHeight)
        {
            var currentPlane = (ksEntity)_part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
            DrawRectangle(caseLength, caseWidth, 0, 0, currentPlane);
            MakeExtrude(caseHeight, _entitySketch);
            MakeShell();
        }

        /// <summary>
        /// Создание отверстия для камеры.
        /// </summary>
        /// <param name="cameraHoleLength">Длина отверстия для камеры.</param>
        /// <param name="cameraHoleWidth">Ширина отверстия для камеры.</param>
        /// <param name="cameraRightGap">Зазор между отверстием для камеры и правой стенкой.</param>
        /// <param name="cameraTopGap">Зазор между отверстием для камеры и верхней стенкой.</param>
        private void CreateCamHole(double cameraHoleLength, double cameraHoleWidth, 
            double cameraRightGap, double cameraTopGap)
        {
            var currentPlane = (ksEntity)_part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
            DrawRectangle(cameraHoleLength, cameraHoleWidth, cameraRightGap,
                cameraTopGap, currentPlane);
            MakeCutExtrude(_entitySketch, (short)Direction_Type.dtReverse);
        }

        /// <summary>
        /// Создание отверстия для боковых кнопок.
        /// </summary>
        /// <param name="sideButtonsHoleWidth">Ширина отверстия боковых кнопок.</param>
        /// <param name="sideButtonsHoleHeight">Высота отверстия боковых кнопок.</param>
        /// <param name="centerHeight">Середина высоты чехла.</param>
        /// <param name="sideButtonsGap">Зазор отверстия боковых кнопок.</param>
        private void CreateSideButtonsHole(double sideButtonsHoleWidth, double sideButtonsHoleHeight, 
            double centerHeight, double sideButtonsGap)
        {
            var currentPlane = (ksEntity)_part.GetDefaultEntity((short)Obj3dType.o3d_planeYOZ);
            DrawRectangle(-sideButtonsHoleWidth, -sideButtonsHoleHeight,
                centerHeight + sideButtonsHoleHeight / 2, -sideButtonsGap, currentPlane);
            MakeCutExtrude(_entitySketch, (short)Direction_Type.dtNormal);
        }

        /// <summary>
        /// Создание отверстия для наушников.
        /// </summary>
        /// <param name="jackDiameter">Диаметр отверстия для наушников.</param>
        /// <param name="jackGap">Зазор для отверстия для наушников.</param>
        /// <param name="caseWidth">Ширина чехла.</param>
        /// <param name="caseLength">Высота чехла.</param>
        /// <param name="centerHeight">Середина высоты чехла.</param>
        private void CreateMiniJackHole(double jackDiameter, double jackGap, double caseWidth,
            double caseLength, double centerHeight)
        {
            var offsetPlaneXoz = CreateOffsetPlaneXoz(caseLength);
            DrawCircle(caseWidth - jackGap, centerHeight, jackDiameter, offsetPlaneXoz);
            MakeCutExtrude(_entitySketch, (short)Direction_Type.dtNormal);
        }

        /// <summary>
        /// Создание отверстия для зарядки.
        /// </summary>
        /// <param name="chargerHoleWidth">Ширина отверстия для зарядки.</param>
        /// <param name="chargerHoleHeight">Высота отверстия для зарядки.</param>
        /// <param name="caseLength">Длина чехла.</param>
        /// <param name="caseWidth">Ширина чехла.</param>
        /// <param name="centerHeight">Середина высоты чехла.</param>
        private void CreateChargerHole(double chargerHoleWidth, double chargerHoleHeight, double caseLength,
            double caseWidth, double centerHeight)
        {
            var offsetPlaneXoz = CreateOffsetPlaneXoz(caseLength);
            DrawRectangle(chargerHoleHeight, chargerHoleWidth, -chargerHoleWidth / 2 + caseWidth / 2,
                centerHeight - chargerHoleHeight / 2, offsetPlaneXoz);
            MakeCutExtrude(_entitySketch, (short)Direction_Type.dtNormal);
        }

        /// <summary>
        /// Создать эскиз.
        /// </summary>
        /// <param name="currentPlane">Плоскость, на которой будет создан эскиз.</param>
        private void CreateSketch(ksEntity currentPlane)
        {
            _entitySketch = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_sketch);
            _sketchDefinition = (ksSketchDefinition)_entitySketch.GetDefinition();
            _sketchDefinition.SetPlane(currentPlane);
            _entitySketch.Create();
        }

        /// <summary>
        /// Выдавливание.
        /// </summary>
        /// <param name="depth">Глубина выдавливания.</param>
        /// <param name="entitySketch">Указатель на интерфейс сущности.</param>
        private void MakeExtrude(double depth, object entitySketch)
        {
            var entityExtrude = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_baseExtrusion);
            var entityExtrudeDefinition = (ksBaseExtrusionDefinition)entityExtrude.GetDefinition();
            entityExtrudeDefinition.SetSideParam(true, 0, depth);
            entityExtrudeDefinition.SetSketch(entitySketch);
            entityExtrude.Create();
        }

        /// <summary>
        /// Вырезать выдавливанием.
        /// </summary>
        /// <param name="entitySketch">Указатель на интерфейс сущности.</param>
        /// <param name="direction">Направление выдавливания.</param>
        private void MakeCutExtrude(object entitySketch, short direction)
        {
            var entityCutExtrusion = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_cutExtrusion);
            var cutExtrusionDefinition = (ksCutExtrusionDefinition)entityCutExtrusion.GetDefinition();
            cutExtrusionDefinition.directionType = direction;
            cutExtrusionDefinition.SetSideParam(true);
            cutExtrusionDefinition.SetSketch(entitySketch);
            entityCutExtrusion.Create();
        }

        /// <summary>
        /// Операция "оболочка" толщиной 1 мм.
        /// </summary>
        private void MakeShell()
        {
            var entityCollectionPart = (ksEntityCollection)_part.EntityCollection((short)Obj3dType.o3d_face);
            var entityShell = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_shellOperation);
            var shellDefinition = (ksShellDefinition)entityShell.GetDefinition();
            shellDefinition.thickness = 1;
            shellDefinition.thinType = true;
            var entityCollectionShell = (ksEntityCollection)shellDefinition.FaceArray();
            entityCollectionShell.Clear();
            entityCollectionShell.Add(entityCollectionPart.GetByIndex(0));
            entityShell.Create();
        }

        /// <summary>
        /// Создание новой плоскости.
        /// </summary>
        /// <param name="offset">Расстояние до плоскости.</param>
        /// <returns></returns>
        private ksEntity CreateOffsetPlaneXoz(double offset)
        {
            var newPlane = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_planeOffset);
            var newPlaneDefinition = (ksPlaneOffsetDefinition)newPlane.GetDefinition();
            newPlaneDefinition.SetPlane((ksEntity)_part.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ));
            newPlaneDefinition.direction = true;
            newPlaneDefinition.offset = offset;
            newPlane.Create();
            newPlane.hidden = false;
            return newPlane;
        }

        /// <summary>
        /// Нарисовать прямоугольник.
        /// </summary>
        /// <param name="height">Высота прямоугольника.</param>
        /// <param name="width">Ширина прямоугольника</param>
        /// <param name="x">Координата базовой точки x пря­моугольника </param>
        /// <param name="y">координата базовой точки y пря­моугольника </param>
        /// <param name="currentPlane">Плоскость на которой рисуется прямоугольник.</param>
        private void DrawRectangle(double height, double width, double x, double y, ksEntity currentPlane)
        {
            CreateSketch(currentPlane);
            _sketchEdit = (ksDocument2D)_sketchDefinition.BeginEdit();
            var param = (ksRectangleParam)_kompas.GetParamStruct((short)StructType2DEnum.ko_RectangleParam);
            param.ang = 0;
            param.height = height;
            param.width = width;
            param.style = 1;
            param.x = x;
            param.y = y;
            _sketchEdit.ksRectangle(param);
            _sketchDefinition.EndEdit();
        }

        /// <summary>
        /// Нарисовать окружность.
        /// </summary>
        /// <param name="xc">Координата x центра окружности.</param>
        /// <param name="yc">Координата у центра окружности.</param>
        /// <param name="radius">Радиус окружности.</param>
        /// <param name="currentPlane">Плоскость на которой рисуется окружность.</param>
        private void DrawCircle(double xc, double yc, double radius, ksEntity currentPlane)
        {
            CreateSketch(currentPlane);
            _sketchEdit = (ksDocument2D)_sketchDefinition.BeginEdit();
            _sketchEdit.ksCircle(xc, yc, radius, 1);
            _sketchDefinition.EndEdit();
        }

        /// <summary>
        ///  Указатель на экземпляр компаса.
        /// </summary>
        private readonly KompasObject _kompas;

        /// <summary>
        ///  Указатель на интерфейс документа.
        /// </summary>
        private ksDocument3D _doc3D;

        /// <summary>
        ///  Указатель на интерфейс компонента.
        /// </summary>
        private ksPart _part;

        /// <summary>
        ///  Указатель на интерфейс сущности.
        /// </summary>
        private ksEntity _entitySketch;

        /// <summary>
        ///  Указатель на интерфейс параметров эскиза.
        /// </summary>
        private ksSketchDefinition _sketchDefinition;

        /// <summary>
        ///  Указатель на эскиз.
        /// </summary>
        private ksDocument2D _sketchEdit;

    }
}