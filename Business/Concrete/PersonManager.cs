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
    //İŞ SINIFI 
    //solid kuralına göre bir sınıf sadece özellik tutabilir, bir sınıf sadece operasyon tutabilir.
    //PersonManager=> vatandaşa maske verdiğim bir otam sunuyor olacak bana
    
    public class PersonManager : IApplicantService //Bunu farklı projelerde Manager yerine Service olarak da görebiliriz.
    {
        //encapsulation (aşağıda parametre alırken yaptık)
        public void ApplyForMask(Person person)
        {


        }

        public List<Person> GetList()
        {
            return null ;
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName, person.LastName,person.DateOfBirthYear ))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
