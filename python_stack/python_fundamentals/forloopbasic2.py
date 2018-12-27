# def biggiesize(arr):
#     for i in range(len(arr)):
#         if arr[i]>0:
#             arr[i]='biggie'
#     print(arr)
# biggiesize([1,2,3,4,5,5,6,-2,-1])


# def countpositives(arr):
#     sum=0
#     for i in range(len(arr)):
#         if arr[i]>0:
#             sum=sum+1
#     arr[len(arr)-1]=sum
#     print(arr)
# countpositives([1,2,3,4,5,6,7,-2,-3])


# def sumtotal(arr):
#     sum=0
#     for i in range(0,len(arr)):
#         sum=sum+arr[i]
#     print(sum)
# sumtotal([1,2,3,4])


# def average(arr):
#     avg=0
#     sum=0
#     for i in range(0,len(arr)):
#         sum=sum+arr[i]
#     avg=sum/len(arr)
#     print(avg)
# average([1,2,3,4])


# def length(arr):
#     print(len(arr))
# length([1,2,3,4])


# def min(arr):
#     min=arr[0]
#     if len(arr)<2:
#         return
#     for i in range(1,len(arr)):
#         if min>arr[i]:
#             min=arr[i]
#     print(min)
# min([1,2,3,4,5,6])


# def max(arr):
#     max=arr[0]
#     if len(arr)<2:
#         return
#     for i in range(1,len(arr)):
#         if max<arr[i]:
#             max=arr[i]
#     print(max)
# max([1,2,3,4,5,6])


# def ultimate(arr):
#     data={
#         'totalsum':0,
#         'avg':0,
#         'min':arr[0],
#         'max':arr[0],
#         'length':len(arr)
#     }
#     sum=0
#     if len(arr)<2:
#         return "nope too short"
#     for i in range(0,len(arr)):
#         data['totalsum']=data['totalsum']+arr[i]
#         if arr[i]>data['max']:
#             data['max']=arr[i]
#         if arr[i]<data['min']:
#             data['min']=arr[i]
#     data['avg']=data['totalsum']/data['length']
#     print(data)
# ultimate([1,2,3,4,5,5,6,7,7])


# def reverselist(arr):
#     newarr=[]
#     i=len(arr)
#     while i>0:
#         i=i-1
#         newarr.append(arr[i])
#     print(newarr)
# reverselist([1,2,3,4,5,6])

