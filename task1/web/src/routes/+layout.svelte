<script lang="ts">
	// NOTE: https://github.com/sveltejs/kit/issues/6720
	import '@fontsource/work-sans/variable-full.css';
	import '@fontsource/playfair-display/variable.css';
	import '../app.postcss';

	import { page } from '$app/stores';

	const related_nav = {
		items: [
			{
				title: '@audacioustux',
				href: '/'
			},
			{
				title: 'Resume',
				href: '/resume'
			}
		],
		label: 'Related'
	};
</script>

<main
	class="w-screen h-screen bg-slate-50 text-slate-700 will-change-scroll scrollbar-stable scroll-smooth"
>
	<slot />
</main>

<div
	class="absolute top-0 left-0 pointer-events-none select-none w-screen h-screen overflow-hidden isolate contain-none text-sm"
>
	<div class="flex justify-between my-2 fixed top-0 z-40 w-full">
		<nav
			aria-label={related_nav.label}
			class="px-2 overflow-x-scroll will-change-scroll scrollbar-hidden pointer-events-auto"
		>
			<ul class="flex space-x-2 flex-nowrap w-fit">
				{#each related_nav.items as { href, title }}
					<li class="flex-initial">
						<a {href}>
							<div
								class="max-w-sm truncate select-none bg-slate-50/95 border border-slate-200 px-2 rounded"
								class:border-emerald-500={$page.url.pathname === href}
							>
								<span>{title}</span>
							</div>
						</a>
					</li>
				{/each}
			</ul>
		</nav>
	</div>
</div>
