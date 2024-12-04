const filter=(arr,fn)=>arr.reduce((fArr,val,ind)=>fn(val,ind)?[...fArr,val]:fArr,[]);
