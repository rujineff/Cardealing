class Window{ 
 
    private bool IsOpen; 
 
    public Window(){ 
        this.IsOpen = false; 
    } 
 
    public void Open(){ 
        if(this.IsOpen == true){ 
            Console.WriteLine("Window already open"); 
        }else{ 
            Console.WriteLine("Window opened"); 
            this.IsOpen = true; 
        } 
    } 
 
    public void Close(){ 
        if(this.IsOpen == false){ 
            Console.WriteLine("Window already is close"); 
        }else{ 
            Console.WriteLine("Window closed"); 
            this.IsOpen = false; 
        } 
    } 
} 