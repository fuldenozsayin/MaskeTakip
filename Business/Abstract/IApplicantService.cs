using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //interface-->Sadece imzayı tutmak için değil bağımlılığı çözmek için interface kullanırız
    //belli metot imzalaeını barındırırlar.Birbirinin alternatifi olan sistemlerin farklı implementasyon yapmasını sağlar
    public interface IApplicantService
    {
        public void ApplyForMask(Person person);
        public List<Person> GetList();
        public bool CheckPerson(Person person);
       
    }
}
