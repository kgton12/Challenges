package Completed;

import java.util.Arrays;

public class FindTheSmallestIntegerInTheArrayClass {
    public static int findSmallestInt(int[] args) {
        return Arrays.stream(args).min().getAsInt();
    }
}
