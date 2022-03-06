using APP.STUDENT_SYSTEM.Infrastructure;
using APP.STUDENT_SYSTEM.Managers;
using System;

namespace APP.STUDENT_SYSTEM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Title = "Student System v.1";

            GroupManager groupMgr = new GroupManager();
            StudentManager studentMgr = new StudentManager();

            readMenu:
            PrintMenu();

            Menu m = ScanerManager.ReadMenu("Menudan sechin:");

            switch (m)
            {
                case Menu.GroupAdd:
                    Group g = new Group();
                    g.Name = ScanerManager.ReadString("Qrupun adini daxil edin:");
                    g.Speciality = ScanerManager.ReadString("Qrupun ixtisaini daxil edin:");

                    groupMgr.Add(g);

                    goto case Menu.GroupsAll;
                  
                case Menu.GroupEdit:
                    break;
                case Menu.GroupRemove:
                    break;
                case Menu.GroupSingle:
                    break;
                 
                case Menu.GroupsAll:
                    ShowAllGroups(groupMgr);


                    goto readMenu;
                case Menu.StudentAdd:
                    Student s = new Student();
                    s.Name = ScanerManager.ReadString("Telebenin adi:");
                    s.Surname = ScanerManager.ReadString("telebenin soyadi: ");
                    s.Birthdate = ScanerManager.ReadDate("dogum tarixi: ");

                    Console.WriteLine("------------");
                    s.GroupId = ScanerManager.ReadInteger("telebenin grupu: ");
                    studentMgr.Add(s);
                    goto case Menu.StudentsAll;
                case Menu.StudentEdit:
                    break;
                case Menu.StudentRemove:
                    break;
                case Menu.StudentSingle:
                    break;
                case Menu.StudentsAll:
                    ShowAllStudents(studentMgr);
                    break;
                case Menu.Exit:
                    goto lEnd;
                default:
                    break;
            }

            lEnd:
            Console.WriteLine("End..");
            Console.WriteLine("Cixmaq uchun her hansisa knopkani sixin");
            Console.ReadKey();
        }

        private static void ShowAllStudents(StudentManager studentMgr)
        {
            Console.Clear();
            Console.WriteLine("************ Groups *********");
            foreach (var item in studentMgr.GetAll())
            {
                Console.WriteLine(item);
            }
        }

        private static void ShowAllGroups(GroupManager groupMgr)
        {
            Console.Clear();
            Console.WriteLine("************ Groups *********");
            foreach (var item in groupMgr.GetAll())
            {
                Console.WriteLine(item);
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine(new String('-', Console.WindowWidth));
            foreach(var item in Enum.GetNames(typeof(Menu)))
            {
              Menu m = (Menu)Enum.Parse(typeof(Menu), item);
              Console.WriteLine($"{((byte)m).ToString().PadLeft(2)}. {item}");
            }
            
            
        }
    }
}
