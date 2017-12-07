import Vue from 'vue'
import Router from 'vue-router'
import Menu from '@/components/NavMenu'
import MainContent from '@/components/MainContent'

Vue.use(Router)

export default new Router({
	routes: [
		{
			path: '/',
			components: {
				default: MainContent,
				menu: Menu
			}
		},
		{
			path: '/:id',
			components: {
				default: MainContent,
				menu: Menu
			}
		},
		{
			path: '/:id/*',
			components: {
				default: MainContent,
				menu: Menu
			}
		}
	]
})
