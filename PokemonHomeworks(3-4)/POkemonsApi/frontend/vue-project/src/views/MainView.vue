<script setup>
    import Search from '../components/Search.vue';
    import { RouterLink } from 'vue-router';
</script>

<template>
    <Search @search-name="searchName"/>
    <div class="cards">
        <RouterLink to="/pokemons">POKEMONS</RouterLink>
    </div>
</template>