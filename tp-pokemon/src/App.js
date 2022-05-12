import addPokemon from './container/addpokemon/addpokemon'
import './App.css';
import Home from './container/Home/home'
import Navbar from './Composant/navbar/navbar'
import Pokemon from './container/pokemon/pokemon'
import { BrowserRouter as Router, Route } from 'react-router-dom'




function App() {
  return (
    <>
      <Router>
        <Navbar>
          <Route path="/" exact component={Home}></Route>
          <Route path="/Pokemon" exact component={Pokemon}></Route>
          <Route path="/ecrire" exact component={addPokemon}></Route>
        </Navbar>

        

      </Router>
    </>
  );

}

export default App;
