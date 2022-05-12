import thunk from 'redux-thunk'
import { applyMiddleware, createStore, combineReducers } from "redux";
import  {pokemonReducer} from "./pokemon/pokemonreducer"

const rootReducer = combineReducers({
    pokemonReducer,
})

const store = createStore(rootReducer,applyMiddleware(thunk))

export default store;