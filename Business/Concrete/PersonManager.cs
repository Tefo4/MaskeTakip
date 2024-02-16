using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //Çıplak class kalmasın 
    public class PersonManager : IApplicantService
    {
        private string Soyad;
        private object Result;

        //enscapsulation
        public void ApplyForMask(Person person)
        {

        }


        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            if (person.NotionalIdentity != 0) ;
            {
                KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
                return
                {
                    client.TCKimlikNoDogrulaAsync
                    (new TCKimlikNoDogrulaRequestBody(123, Ad: "ARDA", Soyad: "ASLAN", DogumYili: 2007)) }
                .Result.Body.TCKimlikNoDogrulaResult;

                } 
            }





        }

    }
}
