var join = function(arr1, arr2) {
    let map = new Map();
    arr1.forEach(obj=>{
        map.set(obj.id,obj)
    })
    arr2.forEach(obj=>{
        map.set(obj.id,{...map.get(obj.id),...obj})
    })
    return Array.from(map.values()).sort((a, b) => a.id - b.id);
};