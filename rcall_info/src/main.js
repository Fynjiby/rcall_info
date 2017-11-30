// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import NavMenu from './NavMenu'
import router from './router'
import routerMenu from './routerMenu'
import VueResource from 'vue-resource'

Vue.use(VueResource)

Vue.config.productionTip = false

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  template: '<App/>',
  components: { App }
})

new Vue({
	el: '#my-side-nav-menu',
	router: routerMenu,
	template: '<NavMenu/>',
	components: { NavMenu }
})
