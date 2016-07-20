using System.Collections.Generic;
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
