package com.company;

public class Main {

    public static void main(String[] args) {
        System.out.println(findMinWithDuplicates(new int[] {4, 4}));
    }


    public static int findMinWithoutDuplicates(int[] nums) {
        int start = 0;
        int end = nums.length - 1;
        return _findMinHelper(start, end, nums);
    }

    public static int findMinWithDuplicates(int[] nums)
    {
        int start = 0;
        int end = nums.length  - 1;
        return _findMinHelperWithDuplicates(start, end, nums);
    }

    public static int _findMinHelper(int start, int end, int nums[]) {
        if (nums.length == 1)
        {
            return nums[0];
        }
        if (nums[start] < nums[end])
        {
            //array has no rotation. First element is minumum;
            return nums[start];
        }
        int mid = 0;

        while(start <= end) {

            mid = (start + end) / 2;
            if (mid - 1 >= 0 && nums[mid] < nums[mid - 1]) {
                // if the current element is less than previous element. THis means it's the pivot and minimum;
                return nums[mid];
            }
            if (mid + 1 <= nums.length - 1 && nums[mid] > nums[mid + 1]) {
                // if the current element is greater than the next element, next element is pivot and minimum.
                return nums[mid + 1];
            }
            //decide where to go.
            if (nums[mid] <= nums[start]) {
                // this means pivot is to the left. equals check coz of duplicates.
                end = mid;
            } else {
                //else , pivot is possibly to right or all elements are equal.
                start = mid;
            }
        }
        return end;
    }

    public static int _findMinHelperWithDuplicates(int start, int end, int nums[]) {
        if (nums.length == 1)
        {
            return nums[0];
        }
        if (nums[start] < nums[end])
        {
            //array has no rotation. First element is minumum;
            return nums[start];
        }
        int mid = 0;

        while(start < end) {
            if (start == end) {
                return nums[start];
            }

            mid = (start + end) / 2;
            System.out.println(String.format("Mid is %d", mid));
            if (mid - 1 >= 0 && nums[mid] < nums[mid - 1]) {
                // if the current element is less than previous element. THis means it's the pivot and minimum;
                return nums[mid];
            }
            if (mid + 1 <= nums.length - 1 && nums[mid] > nums[mid + 1]) {
                // if the current element is greater than the next element, next element is pivot and minimum.
                return nums[mid + 1];
            }
            int leftMin = Integer.MAX_VALUE;
            int rightMin = Integer.MAX_VALUE;
            //decide where to go.
            if (nums[mid] <= nums[start]) {
                // this means pivot could be on left
                leftMin = _findMinHelperWithDuplicates(start, mid, nums);
            }
            if (nums[mid] >= nums[end]) {

                //this means , pivot is possibly to right or all elements are equal.
                rightMin = _findMinHelperWithDuplicates(mid + 1, end, nums);
            }
            return Math.min(leftMin, rightMin);
        }
        return nums[start];
    }





}
