using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;

namespace CADPhoneCase
{
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
        /// Конструктор класса.
        /// </summary>
        /// <param name="kompas">Интерфейс API компаса.</param>
        public PhoneCaseModeling(KompasObject kompas)
        {
            _kompas = kompas;
        }

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

        public void CreateModel()
        {
            _doc3D = (ksDocument3D)_kompas.Document3D();
            _doc3D.Create();
            _doc3D = (ksDocument3D)_kompas.ActiveDocument3D();
            _part = (ksPart)_doc3D.GetPart((short)Part_Type.pTop_Part);
            CreateSketch((short)Obj3dType.o3d_planeXOY);
            _sketchEdit = (ksDocument2D)_sketchDefinition.BeginEdit();
            var rparam = (ksRectangleParam)
                _kompas.GetParamStruct((short)StructType2DEnum.ko_RectangleParam);
            rparam.ang = 0;
            rparam.height = 20;
            rparam.style = 1;
            rparam.width = 20;
            rparam.x = 0;
            rparam.y = 0;
            _sketchEdit.ksRectangle
                (rparam, 0);
            _sketchDefinition.EndEdit();
            MakeExtrude(4, _part, _entitySketch, 0, true);
            MakeShell(_part);
            CreateSketch((short)Obj3dType.o3d_planeXOY);
            _sketchEdit = (ksDocument2D)_sketchDefinition.BeginEdit();
            rparam = (ksRectangleParam)
                _kompas.GetParamStruct((short)StructType2DEnum.ko_RectangleParam);
            rparam.ang = 0;
            rparam.height = 4;
            rparam.style = 1;
            rparam.width = 3;
            rparam.x = 4;
            rparam.y = 4;
            _sketchEdit.ksRectangle
                (rparam, 0);
            _sketchDefinition.EndEdit();
            MakeCutExtrude(_part, 4, _entitySketch, 0, false);
            CreateSketch((short)Obj3dType.o3d_planeYOZ);
            _sketchEdit = (ksDocument2D)_sketchDefinition.BeginEdit();
            rparam = (ksRectangleParam)
                _kompas.GetParamStruct((short)StructType2DEnum.ko_RectangleParam);
            rparam.ang = 0;
            rparam.height = 4;
            rparam.style = 1;
            rparam.width = 1;
            rparam.x = -2;
            rparam.y = -2;
            _sketchEdit.ksRectangle
                (rparam, 0);
            _sketchDefinition.EndEdit();
            MakeCutExtrude(_part, 4, _entitySketch, 0, false);
        }

        /// <summary>
        /// Метод, создающий эскиз.
        /// </summary>
        /// <param name="plane">Плоскость, эскиз которой будет создан.</param>
        private void CreateSketch(short plane)
        {
            var currentPlane = (ksEntity)_part.GetDefaultEntity(plane);
            _entitySketch = (ksEntity)_part.NewEntity((short)Obj3dType.o3d_sketch);
            _sketchDefinition = (ksSketchDefinition)_entitySketch.GetDefinition();
            _sketchDefinition.SetPlane(currentPlane);
            _entitySketch.Create();
        }

        private ksEntity MakeExtrude(float width, ksPart part, ksEntity entitySketch,
            double degrees, bool toForward = true)
        {
            var entityExtrude = (ksEntity)part.NewEntity((short)Obj3dType.o3d_baseExtrusion);
            var entityExtrudeDefinition = (ksBaseExtrusionDefinition)entityExtrude.GetDefinition();
            entityExtrudeDefinition.SetSideParam(toForward, 0, width, degrees, false);
            entityExtrudeDefinition.SetSketch(entitySketch);
            entityExtrude.Create();
            return entityExtrude;
        }

        private ksEntity MakeCutExtrude(ksPart part, float width, object entityForExtrusion,
            double degrees, bool side = false)
        {
            var entityCutExtrusion = (ksEntity)part.NewEntity((short)Obj3dType.o3d_cutExtrusion);
            var cutExtrusionDefinition = (ksCutExtrusionDefinition)entityCutExtrusion.GetDefinition();
            cutExtrusionDefinition.cut = true;
            cutExtrusionDefinition.SetSideParam(side, 0, width, degrees, false);
            cutExtrusionDefinition.SetSketch(entityForExtrusion);
            entityCutExtrusion.Create();
            return entityCutExtrusion;
        }

        private ksEntity MakeShell(ksPart part)
        {
            var entityCollectionPart = (ksEntityCollection)part.EntityCollection((short)Obj3dType.o3d_face);
            var entityShell = (ksEntity)part.NewEntity((short)Obj3dType.o3d_shellOperation);
            var shellDefinition = (ksShellDefinition)entityShell.GetDefinition();
            shellDefinition.thickness = 1;
            shellDefinition.thinType = true;
            var entityCollectionShell = (ksEntityCollection)shellDefinition.FaceArray();
            entityCollectionShell.Clear();
            entityCollectionShell.Add(entityCollectionPart.GetByIndex(0));
            entityShell.Create();
            return entityShell;
        } 
    }
}