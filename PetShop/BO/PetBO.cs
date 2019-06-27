using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.MODEL;
using PetShop.DAO;

namespace PetShop.BO
{
    class PetBO
    {
        public void GravarPet(Pet pet)
        {
            PetDAO petDAO = new PetDAO();
            if (pet.Nome != "")
            {
                petDAO.Insert(pet);
            }
        }

        //BUSCAR PET
        public void BuscarPorId(Pet pet)
        {
            PetDAO petDAO = new PetDAO();

            if (pet.CodPet > 0)
            {
                var petTemp = petDAO.BuscarPorId(pet.CodPet);

                pet.Cliente.Codigo = petTemp.Cliente.Codigo;
                pet.Nome = petTemp.Nome;
                pet.Raca = petTemp.Raca;
                pet.Porte = petTemp.Porte;
                pet.Sexo = petTemp.Sexo;
                pet.Cor = petTemp.Cor;
                pet.Especie = petTemp.Especie;
            }
        }

        //Buscar Por NOme
        public IList<Pet> BuscarNPet(Pet pet)
        {
            PetDAO petDAO = new PetDAO();
            if (pet.Nome != "")
            {
                IList<Pet> petTemp = petDAO.BuscarPorNomeP(pet.Nome);
                return petTemp;
            }
            else
            {
                return null;
            }
        }

        //UPDATE
        public void Editar(Pet pet)
        {

            PetDAO petDAO = new PetDAO();
            if(pet.Nome != "")
            {
                petDAO.Update(pet);
            }
        }
    }


}
