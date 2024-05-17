import { createRouter, createWebHistory } from 'vue-router'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'name',
      component: () => import('../views/MainView.vue')
    },
    {
      path: '/pokemons',
      name: 'Pokemons',
      component: () => import('../views/PokemonsView.vue')
    },
    {
      path: '/pokemon/:id',
      name: 'pokemon',
      // route level code-splitting
      // this generates a separate chunk (About.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: () => import('../views/PokemonView.vue')
    }
  ]
})

export default router
