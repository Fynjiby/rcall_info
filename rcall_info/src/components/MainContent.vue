<template>
    <div class="hello">
        <h1>{{ msg }}</h1>
    </div>
</template>
<script>
    export default {
        name: 'HelloWorld',
        data() {
            return {
                msg: 'Welcome to Your Vue.js App'
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
                this.msg = this.$route.params.id != undefined ? this.$route.params.id : "start";
            }
        }
    }
</script>
