class Program {
    static void Main(string [] args) {
        int ID, ID0, ID10, ID100, ID1000, ID10000, ID100000;
        Console.Write("Input 6 number: ");
        ID = int.Parse(Console.ReadLine());

        Console.Write("Input agency abbreviation: ");
        string name = Console.ReadLine();

            //หลักหน่วย
            int total0 = (int)ID / 10;
            ID0 = ID - (total0 * 10);
            
            // หลักสิบ
            int total10 = (int)ID / 100;
            ID10 = ID - (total10 * 100);    
            ID10 = (ID10 - ID0)/10;
            
            // หลักร้อย
            int total100 = (int) ID/ 1000;
            ID100 = ID - (total100 * 1000); 
            ID100 = (ID100 - (ID0+ID10))/100;

            //หลักพัน
            int total1000 = (int) ID/ 10000;
            ID1000 = ID - (total1000 * 10000); 
            ID1000 = (ID1000 - (ID0+ID10+ID100))/1000;

            //หลักหมื่น
            int total10000 = (int) ID/ 100000;
            ID10000 = ID - (total10000 * 100000);
            ID10000 = (ID10000 - (ID0+ID10+ID100+ID1000))/10000;
            
            //หลักแสน
            int total100000 = (int) ID/ 1000000;
            ID100000 = ID - (total100000 * 1000000);
            ID100000 = (ID100000 - (ID0+ID10+ID100+ID1000+ID10000))/100000;

            if ((name == "CIA") || (name == "FBI") || (name == "NSA")){
            switch(name) {
            case "CIA":
                if(ID % 3 == 0){
                    if ((ID10 != 1) || (ID10 != 3) || (ID10 != 5)){
                        if ((ID1000 > 6) && (ID1000 != 8)) {
                            Console.WriteLine("True");
                            }
                        else {
                            Console.WriteLine("False");
                            }
                    }
                    else {
                            Console.WriteLine("False");
                            }
                }
                else {
                            Console.WriteLine("False");
                            }
            break;

            case "FBI" :
                if((ID100000 >= 4) && (ID100000 <= 7)){
                    if((ID100%2 == 0) && (ID100 != 6)){
                        if ((ID10000 == 1) || (ID10000 == 3) || (ID10000 == 5) || (ID10000 == 7) || (ID10000 == 9)){
                            Console.WriteLine("True");
                        }
                        else {
                            Console.WriteLine("False");
                            }
                    }
                    else {
                            Console.WriteLine("False");
                            }
                }
                else {
                            Console.WriteLine("False");
                            }
            break;

            case "NSA":
                if((ID0 == 1) || (ID == 2) || (ID0 == 5) || (ID0 == 6)){
                    if((ID100%3 == 0) || (ID100 != 6)){
                        if((ID0 == 7) || (ID10 == 7) || (ID100 == 7) || (ID1000 == 7) || (ID10000 == 7) || (ID100000 == 7)){
                            Console.WriteLine("True");
                        }
                        else {
                            Console.WriteLine("False");
                            }
                    }
                    else {
                            Console.WriteLine("False");
                            }
                }
                else {
                            Console.WriteLine("False");
                            }
            break;
            } 
        }
         else{
            Console.WriteLine("Run program again!!!");
         }   
    }
}