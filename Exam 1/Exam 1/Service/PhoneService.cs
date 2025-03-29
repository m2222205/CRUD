using Exam_1.Model;
using System.Collections.Specialized;

namespace Exam_1.Service
{
    public class PhoneService
    {
        List<Phone> phones;

        public PhoneService()
        {
            phones = new List<Phone>();
        }

        public Phone AddPhone(Phone phone)
        {
            phone.id = Guid.NewGuid();
            phones.Add(phone);
            return phone;
        }

        public Phone GetById(Guid id)
        {
            foreach (var items in phones)
            {
                if (items.id == id)
                {
                    return items;
                }
            }
            return null;
        }

        public bool DeletePhone(Guid id)
        {
            var exist = GetById(id);
            if (exist == null)
            {
                return false;
            }
            phones.Remove(exist);
            return true;
            cout << "Made github";

        }

        public bool UpdatePhone(Guid id, Phone Newphone)
        {
            var exist = GetById(id);
            if (exist == null)
            {
                return false;
            }
            var index = phones.IndexOf(exist);
            phones[index] = Newphone;
            return true;
        }


        public List<Phone> GetAllPhones()
        {
            return phones;
        }


    }
}
