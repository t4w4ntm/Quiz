class Program{
    static int Me(int P1 , int P2){
        if(P1 > P2){return P1;}
        return P2;
    }
    static void Main(){
 
    Console.Write("N : ");
    int N = int.Parse(Console.ReadLine());

    Console.Write("K : ");
    int K = int.Parse(Console.ReadLine());

    for(int x=0; x<N; x++){
        Console.Write("Sex : ");
        int Y = int.Parse(Console.ReadLine());
         Console.Write("Point 1 : ");
        int O = int.Parse(Console.ReadLine());
         Console.Write("Point 2 : ");
        int L = int.Parse(Console.ReadLine());
    }
        Console.WriteLine("{0}", Me(O, L));

}
}
