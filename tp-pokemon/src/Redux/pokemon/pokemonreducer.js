/* eslint-disable default-case */
const INITIAL_STATE ={
    pokemons: [],

};

export default function pokemonReducer(state = INITIAL_STATE,action){
    switch (action.type) {
        case "AddPokemon":
            const newPok = [...state.pokemons];
            newPok.unshift(state.payload)
            return {
                ...state,
                pokemons: newPok
            };
            case "LOADPOKEMON":{
                return{
                    ...state,
                    pokemons: action.payload,
                };
            }
    }
    return state;
}