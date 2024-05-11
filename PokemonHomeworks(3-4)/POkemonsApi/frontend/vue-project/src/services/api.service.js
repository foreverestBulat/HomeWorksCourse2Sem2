import axios from 'axios';
import { API_URL } from "./config";

const instance = axios.create({
    baseURL: API_URL,
});


export async function getPokemons(index=0, count=20) {
    const response = await instance.get(`/pokemon/pokemons?index=${index}&count=${count}`);
    return response.data;
}

export async function getPokemon(index) {
    const response = await instance.get(`/pokemon/pokemon?index=${index}`);
    return response.data;
}
