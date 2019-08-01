/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package nyplab2;

/**
 *
 * @author Win7-User
 */
public class SelectionAlgorithm {

    static void SortArray(int[] array) {

        int length = array.length;
        int tempValue;
        int minIndex;

        for (int i = 0; i < length - 1; i++) {

            minIndex = i;

            for (int j = i + 1; j < length; j++) {
                if (array[j] < array[minIndex]) {
                    minIndex = j;
                }
            }

            tempValue = array[i];
            array[i] = array[minIndex];
            array[minIndex] = tempValue;
            String strArray = new String();
            strArray = String.valueOf(i + 1) + ". Adım: ";

            for (int k = 0; k < length; k++) {
                strArray += String.valueOf(array[k]) + " ";//  System.out.println(array[k] + " ");
            }

            System.out.println(strArray);
            strArray=null;
        }
    }
}
