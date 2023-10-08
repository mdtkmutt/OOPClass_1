class Program
{
    public static void Main(string[] args)
    {
        /* 
          ข้อมูลเริ่มต้น : ตัวเลขสักตัวที่เอาไปคำนวณได้ (อัตราส่วน)
          กระบวนการ: 
            1. ฟุต -> นิ้ว อัตราส่วน x 12 
            2. ไมล์ -> ฟุต อัตราส่วน x 5280 
            3. 
                Step 1) ไมล์ -> ฟุต  อัตราส่วน x 5280 
                Step 2) ฟุต -> นิ้ว   นำผลลัพธ์ จากการแปลง ไมล์เป็น ฟุต x 12
          ผลลัพธ์: 
            1. แปลงฟุตเป็นนิ้ว 
            2. แปลงไมล์เป็นฟุต 
            3. แปลงฟุตเป็นนิ้ว(แปลงไฟล์เป็นฟุต)
        */

        UnitConverter feetToInchesConverter = new UnitConverter();
        feetToInchesConverter.ratio = 12;

        UnitConverter milesToFeetConverter = new UnitConverter();
        milesToFeetConverter.ratio = 5280;

        Console.WriteLine("Feet to inches: {0}", feetToInchesConverter.Convert(30));
        Console.WriteLine("Miles to Feet {0}", milesToFeetConverter.Convert(1));
        Console.WriteLine("Feet to Inches from miles: {0}",
        feetToInchesConverter.Convert(milesToFeetConverter.Convert(2)));



        // DogDoor door = new DogDoor();
        // door.Open();

        // Console.WriteLine("Door is open ? : {0}", door.open);
        /* ยี่ห้อ : Toyota 
           รุ่น : Altis 
           จำนวนประตู: 4
           จำนวนล้อ: 4
        */
        // Car myCar = new Car();
        // myCar.brand = "Toyota";
        // myCar.model = "Altis";
        // myCar.numberOfDoors = 4;
        // myCar.numberOfWheels = 4;

        // PrintCarInformation(myCar);

        /* ยี่ห้อ : Tesla 
          รุ่น : Model 3 
          จำนวนประตู: 4
          จำนวนล้อ: 4
       */
        // Car tesla = new Car();
        // tesla.brand = "Tesla";
        // tesla.model = "Model 3";
        // tesla.numberOfDoors = 4;
        // tesla.numberOfWheels = 4;

        // PrintCarInformation(tesla);
    }

    // static void PrintCarInformation(Car car)
    // {
    //     Console.WriteLine("*****************");
    //     Console.WriteLine("Brand: {0}", car.brand);
    //     Console.WriteLine("Model: {0}", car.model);
    //     Console.WriteLine("Number of Door: {0}", car.numberOfDoors);
    //     Console.WriteLine("Number of Wheels: {0}", car.numberOfWheels);
    //     Console.WriteLine(car.MoveForward());
    //     Console.WriteLine("*****************");
    // }
}