using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    public class CGLib
    {
        public static void GenerateFromTemplate(string templateFileName,string entityName, string props)
        {
            //replace template file name with the actual file name
            var entityNameWOModule = entityName.Replace("ONB_", "");
            string actualFilename = templateFileName.Replace("Model1", entityNameWOModule)
                .Replace("srcStructure", "destStructure").Replace(".txt","");
            //create directory
            
            string templateFileData = File.ReadAllText(templateFileName);
            //replace @properties with the actual properties
            templateFileData = templateFileData.Replace("@properties", props);
            //replace @entityName with the actual entity name
            templateFileData = templateFileData.Replace("Model1", entityNameWOModule);


            string destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, actualFilename);

            var dir = Path.GetDirectoryName(destPath);
            try
            {
                Directory.CreateDirectory(dir);
            }
            catch (Exception)
            {

            }
            File.WriteAllText(destPath, templateFileData);  
        }
        public static string GeneratePropertiesCode(Type type)
        {
            StringBuilder sb = new StringBuilder();
            var excludeList = new List<string> { "CreatedById", "CreatedDate", "ModifiedById", "ModifiedDate", "DeletedById", "DeletedDate" };
            var props = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly).Where(p => !excludeList.Contains(p.Name)).ToList();
            foreach (PropertyInfo prop in props)
            {
                Type underlyingType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                string typeName = underlyingType.Name;

                // Append '?' for nullable types
                if (Nullable.GetUnderlyingType(prop.PropertyType) != null)
                {
                    typeName += "?";
                    sb.AppendLine($"    public {typeName} {prop.Name} {{ get; set; }}");
                }
                else
                {
                    sb.AppendLine($"    public required {typeName} {prop.Name} {{ get; set; }}");
                }

            }


            return sb.ToString();
        }
    }
}
