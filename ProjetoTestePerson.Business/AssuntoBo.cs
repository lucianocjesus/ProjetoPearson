using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoTestePerson.Data;
using ProjetoTestePerson.Domain;

namespace ProjetoTestePerson.Business
{
    public class AssuntoBo
    {
        public List<Assuntos> ListaAssuntosBo()
        {
            List<Assuntos> lstList = new AssuntoData().ListaAssuntosData();
            return lstList;
        } 
    }
}
