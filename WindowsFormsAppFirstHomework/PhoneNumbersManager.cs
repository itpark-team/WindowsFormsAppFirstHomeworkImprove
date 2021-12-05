using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsAppFirstHomework
{
    class PhoneNumbersManager
    {
        private List<PhoneNumber> phoneNumbers;
        private const string fileNameTXT = "PhoneListNumbers.txt";
        private const string fileNameBIN = "PhoneListNumbers.bin";

        public PhoneNumbersManager()
        {
            phoneNumbers = new List<PhoneNumber>();
        }

        public void AddPhoneNumber(PhoneNumber phoneNumber)
        {
            phoneNumbers.Add(phoneNumber);
        }

        public bool ReplacePhoneNumber(int index, PhoneNumber phoneNumber)
        {
            if (index >= 0 && index <= phoneNumbers.Count - 1)
            {
                phoneNumbers[index] = phoneNumber;
                return true;
            }
            else
            {
                throw new Exception("Такого контакта не существует");
            }

        }

        public bool DeletePhoneNumber(int index)
        {
            if (index >= 0 && index <= phoneNumbers.Count - 1)
            {
                phoneNumbers.RemoveAt(index);
                return true;
            }
            else
            {
                throw new Exception("такого контакта не существует");
            }
        }

        public List<PhoneNumber> GetAllPhoneNumbers()
        {
            return phoneNumbers;
        }

        public PhoneNumber GetPhoneNumberByIndex(int index)
        {
            return phoneNumbers[index];
        }

        public List<PhoneNumber> GetPhoneNumbersByGrade(PhoneNumber.GradeList grade)
        {
            List<PhoneNumber> temp = new List<PhoneNumber>();

            for (int i = 0; i < phoneNumbers.Count; i++)
            {
                if (phoneNumbers[i].Grade == grade)
                {
                    temp.Add(phoneNumbers[i]);
                }
            }

            return temp;
        }


        public void LoadPhoneNumbersFromTxtFile()
        {
            StreamReader reader = new StreamReader(fileNameTXT);

            int count = Convert.ToInt32(reader.ReadLine());
            phoneNumbers = new List<PhoneNumber>();

            for (int i = 0; i < count; i++)
            {
                string number = reader.ReadLine();
                string name = reader.ReadLine();
                string info = reader.ReadLine();
                PhoneNumber.GradeList grade = (PhoneNumber.GradeList)int.Parse(reader.ReadLine());

                phoneNumbers.Add(new PhoneNumber(number, name, info, grade));
            }

            reader.Close();
        }

        public void SavePhoneNumbersTxtToFile()
        {
            StreamWriter writer = new StreamWriter(fileNameTXT);
            int count = phoneNumbers.Count;
            writer.WriteLine(count);

            for (int i = 0; i < phoneNumbers.Count; i++)
            {
                writer.WriteLine(phoneNumbers[i].Number);
                writer.WriteLine(phoneNumbers[i].Name);
                writer.WriteLine(phoneNumbers[i].Info);
                writer.WriteLine((int)phoneNumbers[i].Grade);
            }

            writer.Close();
        }

        public void LoadPhoneNumbersFromBinFile()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(fileNameBIN, FileMode.Open);

            phoneNumbers = (List<PhoneNumber>)binaryFormatter.Deserialize(fileStream);

            fileStream.Close();
        }

        public void SavePhoneNumbersBinToFile()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(fileNameBIN, FileMode.OpenOrCreate);

            binaryFormatter.Serialize(fileStream, phoneNumbers);

            fileStream.Close();
        }
    }
}
