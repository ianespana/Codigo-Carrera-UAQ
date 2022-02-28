package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Float.parseFloat;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        float[] nums = new float[3];

        System.out.println("Dame la primer cantidad:");
        nums[0] = parseFloat(reader.readLine());

        System.out.println("Dame la segunda cantidad:");
        nums[1] = parseFloat(reader.readLine());

        System.out.println("Dame la tercera cantidad:");
        nums[2] = parseFloat(reader.readLine());

        Float may = Float.MIN_VALUE;

        for (float num:nums) {
            if (num > may){
                may = num;
            }
        }

        System.out.println("La cantidad mas gande es: " + may);
    }
}