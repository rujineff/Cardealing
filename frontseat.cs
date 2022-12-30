class frontseats{
    private bool ischange;

    public frontseats(){
        this.ischange = false;
    }
    public void forwardchange(){
        if(this.ischange == true){
            Console.WriteLine("The seat is already rolled back");
        }else{
            Console.WriteLine("You roll the seat back");
            this.ischange = true;
        }
    }

    public void backchange(){ 
        if(this.ischange == false){ 
            Console.WriteLine("The seat is already rolled forward"); 
        }else{ 
            Console.WriteLine("You roll the seat forward"); 
            this.ischange = false; 
        } 
    } 
}