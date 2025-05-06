using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Xml.Linq;

namespace CodeGenerator
{
    public partial class Form1 : Form
    {
        MapPath mapPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSrc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void LoadSrc()
        {
            string srcRoot = txtSRCPATH.Text;
            mapPath = new MapPath(srcRoot);
            Assembly assembly = Assembly.LoadFrom(mapPath.DomainDLL);

            var types = assembly.GetTypes().Where(a => a.FullName.Contains("Entities") && a.IsClass).OrderBy(a => a.FullName).ToList();
            foreach (Type type in types)
            {
                chkEntityList.Items.Add(type.FullName);
            }

            var files = Directory.GetFiles("srcStructure", "*.txt", SearchOption.AllDirectories).ToList();
            foreach (var file in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                if (!chkFileList.Items.Contains(file))
                {
                    chkFileList.Items.Add(file);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkEntityList.Items.Count; i++)
            {
                chkEntityList.SetItemChecked(i, checkBox1.Checked);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string srcRoot = txtSRCPATH.Text;
            MapPath mapPath = new MapPath(srcRoot);
            Assembly assembly = Assembly.LoadFrom(mapPath.DomainDLL);

            var types = assembly.GetTypes().Where(a => a.FullName.Contains("Entities") && a.IsClass).OrderBy(a => a.FullName).ToList();

            foreach (var classItem in chkEntityList.CheckedItems)
            {
                string className = classItem.ToString();
                //  continue;
                var entityItem = types.FirstOrDefault(t => t.FullName == className);

                var props = CGLib.GeneratePropertiesCode(entityItem);

                var tmp = className.Split('.');
                var clsNameWOONB = tmp[tmp.Length - 1].Replace("ONB_", "");
                foreach (var demoFileName in chkFileList.Items)
                {
                    string demoFileName2 = demoFileName.ToString();

                    CGLib.GenerateFromTemplate(demoFileName2, clsNameWOONB, props);
                }


            }
            MessageBox.Show("Done");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                LoadSrc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
 