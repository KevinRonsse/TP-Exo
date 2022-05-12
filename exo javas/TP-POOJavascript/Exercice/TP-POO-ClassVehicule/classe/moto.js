import {Vehicule} from "./vehicule.js"
export class Moto extends  Vehicule{


    
    constructor(marque,model,Kilometrage,Annee){
        super(marque,model,Kilometrage,Annee)
    }



display(){
    console.log();
}

}