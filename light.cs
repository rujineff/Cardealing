public class light{
    public int LightChosen = 0;

    public light(int lightchose){
        LightChosen = lightchose;
    }

    public void ChangeLightColor(int toColor){
        LightChosen = toColor;
    }

    public void WhichLight(){
        switch (LightChosen)
        {
            case 1:
                Console.WriteLine("frontlight Color is red.");
                break;
            case 2:
                Console.WriteLine("frontlight Color is green.");
                break;
            case 3:
                Console.WriteLine("frontlight Color is yellow.");
                break;
            case 4:
                Console.WriteLine("frontlight Color is white.");
                break;
            case 5:
                Console.WriteLine("frontlight Color is blue.");
                break;
            default:
                break;
        }
    }
}