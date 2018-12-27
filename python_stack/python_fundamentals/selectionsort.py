arr = [64, 25, 12, 22, 11] 
def selectionsort(arr):
    for i in range(len(arr)): 
        min = i 
        for j in range(i+1, len(arr)): 
            if arr[min] > arr[j]: 
                min = j 
        arr[i], arr[min] = arr[min], arr[i] 
    print (arr) 
selectionsort([5,4,3,2,5,4,3,7,8,2])
