using System;
using System.Linq;
using DB = Autodesk.Revit.DB;

namespace RhinoInside.Revit.GH.Types
{
  using Kernel.Attributes;

  [
    ComponentGuid("83088978-8B44-4154-ABC9-A7CA53CA65E5"),
    Name("Parameter Class"),
    Description("Represents a Revit Parameter class."),
  ]
  public class ParameterClass : GH_Enum<RevitAPI.ParameterClass> { }

  [
    ComponentGuid("2A5D36DD-CD94-4306-963B-D9312DAEB0F9"),
    Name("Parameter Binding"),
    Description("Represents a Revit parameter binding type."),
  ]
  public class ParameterBinding : GH_Enum<RevitAPI.ParameterBinding> { }

  [
    ComponentGuid("A3621A84-190A-48C2-9B0C-F5784B78089C"),
    Name("Storage Type"),
    Description("Represents a Revit storage type."),
  ]
  public class StorageType : GH_Enum<DB.StorageType> { }

  [
    ComponentGuid("A5EA05A9-C17E-48F4-AC4C-34F169AE4F9A"),
    Name("Parameter Type"),
    Description("Represents a Revit parameter type."),
  ]
  public class ParameterType : GH_Enum<DB.ParameterType> { }

  [
    ComponentGuid("38E9E729-9D9F-461F-A1D7-798CDFA2CD4C"),
    Name("Unit Type"),
    Description("Represents a Revit unit type."),
  ]
  public class UnitType : GH_Enum<DB.UnitType> { }

  [
    ComponentGuid("ABE3F6CB-CE2D-4DBE-AB81-A6CB884D7DE1"),
    Name("Unit System"),
    Description("Represents a Revit unit system."),
  ]
  public class UnitSystem : GH_Enum<DB.UnitSystem> { }

  [
    ComponentGuid("3D9979B4-65C8-447F-BCEA-3705249DF3B6"),
    Name("Parameter Group"),
    Description("Represents a Revit parameter group."),
  ]
  public class BuiltInParameterGroup : GH_Enum<DB.BuiltInParameterGroup>
  {
    public BuiltInParameterGroup() : base(DB.BuiltInParameterGroup.INVALID) { }
    public override string ToString()
    {
      try { return DB.LabelUtils.GetLabelFor(Value); }
      catch (Autodesk.Revit.Exceptions.InvalidOperationException) { }

      return base.ToString();
    }

    public override Array GetEnumValues() =>
      Enum.GetValues(typeof(DB.BuiltInParameterGroup)).
      Cast<DB.BuiltInParameterGroup>().
      Where(x => x != DB.BuiltInParameterGroup.INVALID).
      OrderBy(x => DB.LabelUtils.GetLabelFor(x)).
      ToArray();
  }

  [
    ComponentGuid("195B9D7E-D4B0-4335-A442-3C2FA40794A2"),
    Name("Category Type"),
    Description("Represents a Revit parameter category type."),
  ]
  public class CategoryType : GH_Enum<DB.CategoryType>
  {
    public CategoryType() : base(DB.CategoryType.Invalid) { }
    public CategoryType(DB.CategoryType value) : base(value) { }

    public override Array GetEnumValues() =>
      Enum.GetValues(typeof(DB.CategoryType)).
      Cast<DB.CategoryType>().
      Where(x => x != DB.CategoryType.Invalid).
      ToArray();

    public override string ToString()
    {
      if (Value == DB.CategoryType.AnalyticalModel)
        return "Analytical";

      return base.ToString();
    }
  }

  [
    ComponentGuid("1AF2E8BF-5FAF-41AD-9A2F-EB96A706587C"),
    Name("Graphics Style Type"),
    Description("Represents a graphics style type."),
  ]
  public class GraphicsStyleType : GH_Enum<DB.GraphicsStyleType>
  {
    public GraphicsStyleType() : base(DB.GraphicsStyleType.Projection) { }
    public GraphicsStyleType(DB.GraphicsStyleType value) : base(value) { }
  }

  [
    ComponentGuid("F992A251-4085-4525-A514-298F3155DF8A"),
    Name("View Detail Level"),
    Description("Represents a view detail level."),
  ]
  public class ViewDetailLevel : GH_Enum<DB.ViewDetailLevel> { }

  [
    ComponentGuid("83380EFC-D2E2-3A9E-A1D7-939EC71852DD"),
    Name("View Discipline"),
    Description("Represents a Revit view discipline."),
  ]
  public class ViewDiscipline : GH_Enum<DB.ViewDiscipline> { }

  [
    ComponentGuid("BF051011-660D-39E7-86ED-20EEE3A68DB0"),
    Name("View Type"),
    Description("Represents a Revit view type."),
  ]
  public class ViewType : GH_Enum<DB.ViewType> { }

  
  [
    ComponentGuid("2FDE857C-EDAB-4999-B6AE-DC531DD2AD18"),
    Name("Image Fit direction type"),
    Description("Represents a Revit fit direction type."),
  ]
  public class FitDirectionType : GH_Enum<DB.FitDirectionType>
  {
    public FitDirectionType() : base(DB.FitDirectionType.Horizontal) { }
    public FitDirectionType(DB.FitDirectionType value) : base(value) { }
  }

  [
    ComponentGuid("C6132D3E-1BA4-4BF5-B40C-D08F81A79AB1"),
    Name("Image Resolution"),
    Description("Represents a Revit image resolution."),
  ]
  public class ImageResolution : GH_Enum<DB.ImageResolution>
  {
    public ImageResolution() : base(DB.ImageResolution.DPI_72) { }
    public ImageResolution(DB.ImageResolution value) : base(value) { }
  }

  [
    ComponentGuid("F6BABEFF-C4AD-49D0-81D6-9C3CD021DD45"),
    Name("Image FileType"),
    Description("Represents a Revit image file type."),
  ]
  public class ImageFileType : GH_Enum<DB.ImageFileType>
  {
    public ImageFileType() : base(DB.ImageFileType.BMP) { }
    public ImageFileType(DB.ImageFileType value) : base(value) { }
  }


  [
    ComponentGuid("2A3E4872-EF41-442A-B886-8B7DBA73DFE2"),
    Name("Wall Location Line"),
    Description("Represents a Revit wall location line."),
  ]
  public class WallLocationLine : GH_Enum<DB.WallLocationLine>
  {
    public override string ToString()
    {
      switch (Value)
      {
        case DB.WallLocationLine.WallCenterline: return "Wall Centerline";
        case DB.WallLocationLine.CoreCenterline: return "Core Centerline";
        case DB.WallLocationLine.FinishFaceExterior: return "Finish Face: Exterior";
        case DB.WallLocationLine.FinishFaceInterior: return "Finish Face: Interior";
        case DB.WallLocationLine.CoreExterior: return "Core Face: Exterior";
        case DB.WallLocationLine.CoreInterior: return "Core Face: Interior";
      }

      return base.ToString();
    }
  }

  [
    ComponentGuid("2F1CE55B-FD85-4EC5-8638-8DA06932DE0E"),
    Name("Structural Wall Usage"),
    Description("Represents a Revit structural wall usage."),
  ]
  public class StructuralWallUsage : GH_Enum<DB.Structure.StructuralWallUsage> { }

}
