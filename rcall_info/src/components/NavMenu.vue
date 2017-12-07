<template>
    <div class="navbar-default sidebar" role="navigation">
        <div class="sidebar-nav navbar-collapse">
            <ul class="nav" id="side-menu">
                <li v-for="item in itemsMenu">
                    <router-link v-if=!item.haveChild :to="item.link" class="hvr-bounce-to-right">
                        <img class="nav_icon" :src="item.image" /><span class="nav-label">{{ item.text }}</span><span v-if=item.haveChild class="fa"></span>
                    </router-link>
                    <a v-if=item.haveChild @click="toggle(item)" class="hvr-bounce-to-right a-have-child">
                        <img class="nav_icon" :src="item.image" /><span class="nav-label">{{ item.text }}</span><span v-if=item.haveChild class="fa arrow-menu" v-bind:class="{ 'fa-angle-down': item.open, 'fa-angle-left': !item.open }"></span>
                    </a>
                    <transition name="fade">
                        <ul v-if=item.haveChild v-show=item.open class="nav nav-second-level">
                            <li v-for="childitem in item.childItems">
                                <router-link :to="childitem.link" class="hvr-bounce-to-right">
                                    <img class="nav_icon item-menu-child" :src="childitem.image" /><span class="nav-label">{{ childitem.text }}</span>
                                </router-link>
                            </li>
                        </ul>
                    </transition>
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
            '$route.params.id': 'fetchData'
        },
        methods: {
            fetchData() {
                var pathGet = this.$route.params.id != undefined ? this.$route.params.id : "start";
                this.$http.get('/api/' + pathGet).then((res) => {
                    this.itemsMenu = res.body.itemsMenu
                }).catch((ex) => console.log(ex))
            },
            toggle: function (item) {
                if (item.haveChild) {
                    item.open = !item.open;
                }
            },
        }
    }
</script>
