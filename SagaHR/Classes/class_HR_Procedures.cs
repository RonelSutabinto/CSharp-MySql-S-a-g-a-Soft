using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;

namespace SagaHR.Classes
{
    class class_HR_Procedures
    {
        public void Show_Employee(string sCode)
        {
            class_Procedures.splash_Show("Employee Profile");
            var frm = new SagaHR.Forms.frm_Employee();
            frm.Show();

            class_Saga_Procedures.Initialize_Branch(frm.xuc_Employee.Employee_Branch);
            frm.xuc_Employee.Control_Retrieve(sCode);
            class_Procedures.splash_Close();
        }
    }
}
