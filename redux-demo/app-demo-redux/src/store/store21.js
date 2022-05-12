import {configureStore}  from "@reduxjs/toolkit";
import CounterReducer from "../reducer/CounterReducer";
import PriceReducer from "../reducer/pricereducer";
import {combineReducers} from "redux"

const rootReducer = combineReducers({
    CounterReducer,
    PriceReducer

});


const store21 = configureStore({reducer: rootReducer});

export default store21;