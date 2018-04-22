import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        System.out.print("Enter a number: ");
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        isAmicable (n);
    }

    public static void isAmicable(int a){
        int b = divisorSum(a);
        System.out.println("d("+a+") = " + b);
        a = divisorSum(b);
        System.out.println("d("+b+") = " + a);

        if(b !=a && divisorSum(a)==b){
            System.out.println(a+" and "+b+" are an amicable pair");
        }else{
            System.out.println(a+" and "+b+" are NOT an amicable pair");
        }
    }

    public static int divisorSum( int n) {
        int a =0;
        for(int i=1; i <n; i++){
            if(n%i==0){
                a+=i;
            }
        }
        return a;
    }
}
