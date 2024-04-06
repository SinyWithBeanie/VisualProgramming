using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iKnow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbAllCourses.Items.AddRange(new object[] { "Strukturno", "Objektno", "Napredno", "Vizuelno" });
        }

        private void lbAllCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (tbCourseName.Text.Length > 0)
            {
                foreach (var item in lbAllCourses.Items)
                {
                    if (item.ToString().Equals(tbCourseName.Text))
                    {
                        return;
                    }
                }
                lbAllCourses.Items.Add(tbCourseName.Text);
                tbCourseName.Clear();
            }
        }

        private void btnMoveEnrolled_Click(object sender, EventArgs e)
        {
            foreach (var item in lbAllCourses.SelectedItems)
            {
                clbEnrolledCourses.Items.Add(item);
            }

           while (lbAllCourses.SelectedItems.Count > 0)
            {
                lbAllCourses.Items.Remove(lbAllCourses.SelectedItems[0]);
            }
        }

        private void btnMoveBackAllCourses_Click(object sender, EventArgs e)
        {
            foreach (var item in clbEnrolledCourses.SelectedItems)
            {
                lbAllCourses.Items.Add(item);
            }

            while (clbEnrolledCourses.SelectedItems.Count > 0)
            {
                clbEnrolledCourses.Items.Remove(clbEnrolledCourses.SelectedItems[0]);
            }
        }
    }
}
