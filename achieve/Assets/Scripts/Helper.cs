using UnityEngine;

public static class Helper
{
    public static bool IsArrayEmpty(object[] arr) {
        if (arr == null || arr.Length == 0){
            return true;
        }
        else{
            return false;
        }
    }
}