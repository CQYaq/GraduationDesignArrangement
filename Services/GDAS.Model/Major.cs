namespace GDAS.Model;

//专业
public class Major:BaseModel
{
    public string Name { get; set; } // 专业名称
    public string? College { get; set; } // 所属学院
}