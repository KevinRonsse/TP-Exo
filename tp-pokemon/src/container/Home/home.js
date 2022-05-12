import { useSelector, useDispatch } from "react-redux";
import { useEffect, useState } from "react";
import { Link} from "react-router-dom"
import "./home.css"
import {getPokemon} from "../../Services/pokemon-service"
import {CartPokemon} from "../../Composant/Cart/cartP"


function Home(){

    const {pokemons} = useSelector((state)=> ({
        ...state.pokemonReducer,
    }));

    const dispatch = useState();

    useEffect(() =>{
        if(pokemons.length === 1) {
            const data = getPokemon().then(res => {
                console.log(res.data);
                dispatch({
                    type: "LOADPOKEMONs",
                    payload: res.data,
                });
            });
        }
    },[]);

    return (
        <>

        <h1 className="home-name">tout les pokemons</h1>
        <div className="container-cards">
            {pokemons?.map((item)=> {
            return(
                <CartPokemon >
                    <h2>{item.name}</h2>
                    <Link to={{
                        pathname: '/pokemon',
                        state:{
                            image: item.urlImage,
                            name: item.name


                        }
                    }}
                    >
                        Detail du pokemon
                    </Link>
                </CartPokemon>
            );
            })}
        </div>
        </>
    );
}
export default Home;