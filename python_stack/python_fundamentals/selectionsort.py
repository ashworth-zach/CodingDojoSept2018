def selectionsort(arr):
    newarr=[]
    min=arr[0]
    loop=0
    for loop in range(loop,len(arr)):
        if min > arr[loop]:
            arr[loop], min = min, arr[loop]
        print(min,arr[loop])
selectionsort([5,4,3,2,1])

            