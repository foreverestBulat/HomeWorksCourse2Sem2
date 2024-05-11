<script setup>
    import Stats from '../components/Stats.vue'
</script>

<template>
    <Stats :pokemon="details" percent="40" color="#000000"/>
</template>

<script>
    import { getPokemon } from '../services/api.service.js'

    export default {
        data () {
            return {
                details: null
            }
        },
        watch: {
            '$route.params.id': {
                immediate: true,
                async handler(id) {
                    this.details = await getPokemon(id);
                    console.log(this.details);
                }
            }
        }
    }
</script>