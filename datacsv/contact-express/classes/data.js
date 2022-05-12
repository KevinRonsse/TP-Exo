import {Contact} from "./contact.js"
import {appendFileSync,writeFileSync} from "fs"
import LineByline from "n-readlines"

export class Data {
    constructor() {
        this.contacts = []
        this.compteur = 0
        this.fichier= "data.csv"
    
    }

    ajouterContact(nom, prenom, telephone, email) {
        const contact = new Contact(++this.compteur, nom, prenom, email, telephone)
        this.contacts.push(contact)
        appendFileSync(this.fichier, `${contact.nom};${contact.prenom}; ${contact.telephone}; ${contact.email};`)
    }

    lire(){
        this.contacts = []
        const reader = new LineByline(this.fichier)
        let line
        while(line = reader.next()) {
            const données =line.toString().split(';')
            const contact =new Contact(données[0],données[1],données[2],données[3],données[4])
            this.contact.push(contact)
        }
this.compteur =this.contacts[this.contacts.length-1].id
return this.contacts
    }

    recuperContact(id) {
        return this.contacts.find(c => c.id == id)
    }

    //Modifier => id, nouveau nom, nouveau prénom, nouvel email, nouveau telephone

    modifierContact(id, nom, prenom, telephone, email) {
        const contact = this.recuperContact(id)
        if(contact != undefined) {
            contact.nom = nom
            contact.prenom = prenom
            contact.telephone = telephone
            contact.email = email
            this.ecrire()
            return true
        }
        return false
    }

    ecrire(){
        let content =""
        this.contacts.forEach(contact =>{
            content +=`${contact.nom} ${contact.prenom} ${contact.telephone}`;
        })
        writeFileSync(this.fichier,content)

    }

    //Supprimer => id

    supprimerContact(id) {
        const contact = this.recuperContact(id)
        if(contact != undefined) {
            this.contacts = this.contacts.filter(c => c.id != id)
            this.ecrire()
            return true
        }
        return false
    }
}