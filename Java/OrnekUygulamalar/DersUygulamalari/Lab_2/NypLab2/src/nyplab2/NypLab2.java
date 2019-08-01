/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package nyplab2;

import java.util.Random;
import java.util.Scanner;

/**
 *
 * @author Win7-User
 */
public class NypLab2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int[] array = new int[]{10, 4, 5, 1, 2, 6, 12, 8};
        SelectionAlgorithm.SortArray(array);

//        Play();
    }

    static void Play() {
       
        Scanner input = new Scanner(System.in);
        byte isContinuing;
        int totalSuccess = 0;
        int totalPlay = 0;

        do {
            System.out.println("Tahmin edilecek sayı rastgele belirleniyor...");

            Random rnd = new Random();
            int rndNumber = rnd.nextInt(100);
            System.out.println("Random Number :" + Integer.toString(rndNumber));

            boolean isSucceded = PredictNumber(rndNumber);
            totalPlay++;

            if (isSucceded) {
                totalSuccess++;
            }

            System.out.println("OYUN DEVAM ETSİN Mİ devam=1 bitir=0");
            isContinuing = input.nextByte();

        } while (isContinuing == 1);

        System.out.println("Toplam: " + Integer.toString(totalPlay)
                + " oyun oynanmış ve " + Integer.toString(totalSuccess) + " oyunda başarı elde edilmiştir");
    }

    static boolean PredictNumber(int rndNumber) {

        Scanner input = new Scanner(System.in);

        int step = 0;
        int totalStep = 3;
        System.out.println("Toplam: " + Integer.toString(totalStep) + " hakkınız vardır!");
        boolean isFound = false;

        while (step++ < totalStep) {

            System.out.println("\nSayıyı giriniz...");
            int number = input.nextInt();

            if (number == rndNumber) {
                isFound = true;
                break;
            }

            if (number < rndNumber) {
                System.out.println("Tahmin edilecek sayı " + Integer.toString(number) + " sayısından BÜYÜKTÜRtür..");
            } else if (number > rndNumber) {
                System.out.println("Tahmin edilecek sayı " + Integer.toString(number) + " sayısından KÜÇÜKTÜRtür...");
            }

            System.out.println(Integer.toString(totalStep - step) + " adımınız kaldı");

        }

        if (isFound) {
            System.out.println(Integer.toString(rndNumber) + "sayısı " + Integer.toString(step) + " adımda başarıyla bulundu.");
        } else {
            System.out.println(" OYUN BAŞARISIZLIKLA SONA ERMİŞTİR!");
        }

        return isFound;
    }
}
