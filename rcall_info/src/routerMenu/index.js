import Vue from 'vue'
import Router from 'vue-router'
import Menu from '@/components/NavMenuStart'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Menu',
	  component: Menu
    }
  ]
})
