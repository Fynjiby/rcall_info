<template>
	<div class="hello">
		<h1>{{ msg }}</h1>
	</div>
</template>

<script>
	export default {
		name: 'HelloWorld',
		data () {
			return {
				msg: 'Welcome to Your Vue.js App'
			}
		},
	created () {
		this.$http.get('/api/hello').then((res) => {
				this.msg = res.body.message
			}).catch((ex) => console.log(ex))
		}
	}
</script>

