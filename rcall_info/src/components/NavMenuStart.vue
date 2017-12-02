<template>
	<div class="navbar-default sidebar" role="navigation">
		<div class="sidebar-nav navbar-collapse">
			<ul class="nav" id="side-menu">
				<li v-for="item in itemsMenu">
					<router-link :to="item.link" class="hvr-bounce-to-right">
						<img class="nav_icon" :src="item.image" /><span class="nav-label">{{ item.text }}</span><span v-if=item.haveChild class="fa arrow"></span>
					</router-link>
					<ul v-if=item.haveChild class="nav nav-second-level">
						<li v-for="childitem in item.childItems">
							<router-link :to="childitem.link" class="hvr-bounce-to-right">
								<img class="nav_icon" :src="childitem.image" /><span class="nav-label">{{ childitem.text }}</span>
							</router-link>
						</li>
					</ul>

				</li>
			</ul>
		</div>
	</div>
</template>
<script>
	export default {
		name: 'StartMenu',
		data() {
			return {
				itemsMenu: []
			}
		},
		props: {
			ph: {
				type: String,
				default: ''
			}
		},
		created() {
			this.fetchData()
		},
		watch: {
			'$route': 'fetchData'
		},
		methods: {
			fetchData() {
				var pathGet = this.$route.params.id != undefined ? this.$route.params.id : "start";
				this.$http.get('/api/' + pathGet).then((res) => {
					this.itemsMenu = res.body.itemsMenu
				}).catch((ex) => console.log(ex))
			}
		}
	}
</script>
