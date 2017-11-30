<template>
	<div class="navbar-default sidebar" role="navigation">
		<div class="sidebar-nav navbar-collapse">
			<ul class="nav" id="side-menu">
				<li v-for="item in items">
					<router-link to="/home" class="hvr-bounce-to-right">
						<img class="nav_icon " src="/images/quad.svg" /><span class="nav-label">{{ item.text }}</span>
					</router-link>
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
				items: []
			}
		},
		created() {
			this.$http.get('/api/hello').then((res) => {
				this.items = res.body.items
			}).catch((ex) => console.log(ex))
		}
	}
</script>
