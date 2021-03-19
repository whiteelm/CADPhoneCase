using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;

namespace CADPhoneCase
{
    /// <summary>
    /// Создание модели.
    /// </summary>
    public class PhoneCaseModeling
    {
        /// <summary>
        ///  Указатель на экземпляр компаса.
        /// </summary>
        private KompasObject _kompas;

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

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="kompas">Интерфейс API компаса.</param>
        public PhoneCaseModeling(KompasObject kompas)
        {
            _kompas = kompas;
        }

        /// <summary>
        /// Создание модели на основе входных параметров.
        /// </summary>
        /// <param name="parameters">Размеры чехла.</param>
        public void CreateModel(PhoneCaseParameters parameters)
        {
            var caseLength = parameters.CaseLength;
            var caseWidth = parameters.CaseWidth;
            var caseHeight = parameters.CaseHeight;
            var cameraHoleWidth = parameters.CameraHoleWidth;
            var cameraHoleLength = parameters.CameraHoleLength;
            var cameraRightGap = parameters.CameraRightGap;
            var cameraTopGap = parameters.CameraTopGap;
            var chargerHoleWidth = parameters.ChargerHoleWidth;
            var chargerHoleHeight = parameters.ChargerHoleHeight;
            var jackDiameter = parameters.MiniJackDiameter;
            var jackGap = parameters.MiniJackGap;
            var sideButtonsHoleHeight = parameters.SideButtonsHoleHeight;
            var sideButtonsHoleWidth = parameters.SideButtonsHoleWidth;
            var sideButtonsGap = parameters.SideButtonsGap;
            var centerHeight = -caseHeight / 2 - 0.5;
            _doc3D = (ksDocument3D)_kompas.Document3D();
            _doc3D.Create();
            _doc3D = (ksDocument3D)_kompas.ActiveDocument3D();
            _part = (ksPart)_doc3D.GetPart((short)Part_Type.pTop_Part);
            //Создание основы чехла
            var currentPlane = (ksEntity)_part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
            DrawRectangle(caseLength, caseWidth, 0, 0, currentPlane);
            MakeExtrude(caseHeight, _entitySketch);
            MakeShell();
            //Создание отверстия для камеры
            currentPlane = (ksEntity)_part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
            DrawRectangle(cameraHoleLength, cameraHoleWidth, cameraRightGap, cameraTopGap, currentPlane);
            MakeCutExtrude(_entitySketch, (short)Direction_Type.dtReverse);
            //Создание отверстия для боковых кнопок
            currentPlane = (ksEntity)_part.GetDefaultEntity((short)Obj3dType.o3d_planeYOZ);
            DrawRectangle(-sideButtonsHoleWidth, -sideButtonsHoleHeight, centerHeight + sideButtonsHoleHeight/2,
                -sideButtonsGap, currentPlane);
            MakeCutExtrude(_entitySketch, (short)Direction_Type.dtNormal);
            //Создание отверстия для наушников
            var offsetPlaneXOZ = CreateOffsetPlaneXOZ(caseLength);
            DrawCircle(caseWidth- jackGap, centerHeight, jackDiameter, offsetPlaneXOZ);
            MakeCutExtrude(_entitySketch, (short)Direction_Type.dtNormal);
            //Создание отверстия для зарядки
            DrawRectangle(chargerHoleHeight, chargerHoleWidth, -chargerHoleWidth/2 + caseWidth / 2, 
                centerHeight - chargerHoleHeight/2, offsetPlaneXOZ);
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
        private ksEntity CreateOffsetPlaneXOZ(double offset)
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
    }
}