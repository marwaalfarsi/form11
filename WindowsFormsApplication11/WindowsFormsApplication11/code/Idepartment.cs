using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication11.code
{
    interface Idepartment
    {
        public void insert(string name, string code);
        public void Edite(int id, string name, string code);

        public bool isex_name(string name);
        public bool isex_code(string code);

        public DataTable Getall();
        public System.Data.DataRow Getbyid(int id);


        public void Delete(int id);

        public bool isusedinstudent();
        public bool isusedincourse();

    }
}
