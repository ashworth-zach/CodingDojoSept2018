function binarySearch(arr, num){
    var mid = Math.floor(arr.length/2);

    if (num == arr[mid]){
        return arr[mid];
    } else if (num > arr[mid] && arr.length > 1){
        newarr = arr.splice(mid, mid+1);
        console.log(newarr)
        return binarySearch(newarr,num);
    }
    else if (num < arr[mid] && arr.length > 1){
        newarr = arr.splice(0, mid);
        console.log(newarr)
        return binarySearch(newarr,num);
    } else {
        return -1;
    }
}

binarySearch([1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25], 9)