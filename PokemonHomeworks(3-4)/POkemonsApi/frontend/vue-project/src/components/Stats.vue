<script setup>
    import ProgressBar from './ProgressBar.vue';
</script>

<template>

    <div class="main-state child">
        <div class="name-id-types">
            <div class="name-id">
                <div class="id">#{{ pokemon.id }}</div>
                <div class="name">{{ pokemon.name }}</div>
            </div>
            <div>
                <div v-for="type in types" :style="{ backgroundColor: type.color, color: type.textcolor }">
                    <p>{{ type.name }}</p>
                </div>
            </div>
        </div>
        <div class="stats-image">
            <ProgressBar
                :color="hp"
                :percent="pokemon.hp"/>
            <ProgressBar
                :color="attack"
                :percent="pokemon.attack"/>
            <ProgressBar
                :color="defense"
                :percent="pokemon.defense"/>
            <ProgressBar
                :color="specialAttack"
                :percent="pokemon.specialAttack"/>
            <ProgressBar
                :color="specialDefense"
                :percent="pokemon.specialDefense"/>
            <ProgressBar
                :color="speed"
                :percent="pokemon.speed"/>
            <div>
                <img :src="pokemon.image"/>
            </div>
        </div>
    </div>
    <div class="stats">
        <!-- :color="" -->
        
    </div>
</template>

<script>
    export default {
        data () {
            return {
                types: [],
                hp: '#00FF00',
                attack: '#FF0000',
                defense: '#0000FF',
                specialAttack: '#800000',
                specialDefense: '#000080',
                speed: '#FFFF00',
                accuracy: '#D2691E',
                evasion: '#6A5ACD',
                percent: 30,
            }
        },
        props: {
            attackPer: {
                type: Number,
                default: 30
            },
            pokemon: {
                type: Object,
                default: null
            }
        },
        mounted(){
            for(let i = 0; i < this.pokemon.types.length; i++){
                this.types.push({
                    name: this.pokemon.types[i],
                    color: types[this.pokemon.types[i]][0],
                    textcolor: types[this.pokemon.types[i]][1]
                });
            }
        }
    }

    const types = {
        'normal': ['#A52A2A', 'white'],
        'fighting': ['#FFA500', 'white'],
        'flying': ['#5F9EA0', 'white'],
        'poison': ['#9400D3', 'white'],
        'ground': ['#D2691E', 'white'],
        'rock': ['#8B4513', 'white'],
        'bug': ['#006400', 'white'],
        'ghost': ['#483D8B', 'white'],
        'steel': ['#00FF7F', 'white'],
        'fire': ['#FF0000', 'white'],
        'water': ['#0000FF', 'white'],
        'grass': ['#008000', 'white'],
        'electric': ['#FFFF00', 'black'],
        'phychic': ['#DB7093', 'black'],
        'ice': ['#ADD8E6', 'white'],
        'dragon': ['#00FFFF', 'white'],
        'dark': ['#000000', 'white'],
        'fairy': ['#DC143C', 'white'],
        'unknown': ['#A9A9A9', 'white'],
        'shadow': ['#191970', 'white']
    }
</script>