var expect = function(val){
function toBe(nval){
if(val===nval){
return true;}
throw new Error("Not Equal");
};function notToBe(nval){
if(val!==nval){return true;}
throw new Error("Equal");
}return { toBe: toBe, notToBe: notToBe};   };