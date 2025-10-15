package Completed;

import java.util.Arrays;

public class SumOfPositiveClass {
    public static int sum(int[] arr) {
        return Arrays.stream(arr).filter(x -> x > 0).sum();
    }
}