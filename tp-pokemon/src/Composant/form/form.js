import React, { useState, useEffect } from "react";
import { useSelector, useDispatch } from "react-redux";
import "./form.css";
import Navbar from "../navbar/navbar"


export default function FormPokemon() {
    const [pokemon, setPokemon] = useState({

        urlImage: "",
        id: 1,
        name: ''

    })

    const dispatch = useDispatch();

    const handleForm = (e) => {
        e.preventDefault();

        const newPokemon = {
            urlImage: pokemon.urlImage,
            id: pokemon.id,
            name: pokemon.name
        };

        dispatch({
            type: 'AddPokemon',
            payload: pokemon,
        });

        setPokemon({
            urlImage: "",
            id: "",
            name: "",
        })
    };

    const addNewImage = (e) => {
        const newObjState ={...pokemon, urlImage: e.target.value}
        setPokemon(newObjState);
    }


    const addNewId = (e) => {
        const newObjState = { ...pokemon, id: e.target.value }
        setPokemon(newObjState);

    };
    const addNewName = (e) => {
        const newObjState = { ...pokemon, name: e.tagert.value };
        setPokemon(newObjState);
    };

    return(
        <>
        <Navbar />
        <h1 className="Name-form"> ecriver un pokemon</h1>
        <form className="container-form" onSubmit={handleForm}>
            <label htmlFor="Name">Name</label>
            <input 
            value={pokemon.name}
            onInput={addNewName}
            type="text"
            id="name"
            placeholder="entrer votre pokemon"
            />
              <label htmlFor="pokemon">Votre pokemon</label>
        <textarea
          value={pokemon.id}
          onInput={addNewId}
          id="pokemon"
          placeholder="Votre pokemon"
        ></textarea>
        

        <button>Envoyer pokemon</button>
        </form>


        </>
    )
}