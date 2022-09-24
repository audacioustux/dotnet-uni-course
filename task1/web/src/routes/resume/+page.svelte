<script lang="ts">
	const fetchReferences = (async () => {
		const response = await fetch('https://localhost:7218/ResumeReferences');
		return await response.json();
	})();

	const bio = [
		{
			title: 'Name',
			value: 'Tanjim Hossain'
		},
		{
			title: 'Born',
			value: '1998'
		},
		{
			title: 'Website',
			value: 'https://audacioustux.com'
		},
		{
			title: 'Email',
			value: 'audacioustux@icloud.com'
		},
		{
			title: 'Phone Number',
			value: '+880-1823170374'
		},
		{
			title: 'Location',
			value: 'Dhaka, Bangladesh'
		}
	];
	const skills = [
		'Typescript',
		'Rust',
		'Scala',
		'Java',
		'C++',
		'GraalVM',
		'Kubernetes',
		'Oracle Cloud',
		'Terraform',
		'Ansible',
		'Flink',
		'WebAssembly',
		'Argo CI/CD',
		'Svelte',
		'WAMR',
		'Elixir',
		'XState',
		'Vim'
	];
	const projects = [
		{
			title: 'Computer Graphics',
			href: 'https://github.com/audacioustux/CG-Group-Project'
		},
		{
			title: 'Web Technology',
			href: 'https://github.com/audacioustux/uni-assignments/tree/master/semester%207/web_tehc/aloblog'
		}
	];
</script>

<section class="flex justify-center min-h-screen-min py-8 font-serif antialiased select-none">
	<div class="prose prose-lg prose-slate my-8 flex-1">
		<h1>Resume</h1>

		<h2>Bio</h2>

		<dl>
			{#each bio as { title, value }}
				<div>
					<dt class="inline">{title}</dt>
					<dd class="inline">{value}</dd>
				</div>
			{/each}
		</dl>

		<h2>Skills</h2>

		<ul class="grid grid-cols-2 md:grid-cols-3">
			{#each skills as skill}
				<li>{skill}</li>
			{/each}
		</ul>

		<h2>Projects</h2>

		<dl>
			{#each projects as { title, href }}
				<div>
					<dt class="inline">{title}</dt>
					<dd class="inline">
						<a {href}> Link </a>
					</dd>
				</div>
			{/each}
		</dl>

		<h2>Reference</h2>
		<ul>
			{#await fetchReferences}
				...
			{:then references}
				{#each references as { name, link }}
					<li><a href={link}>{name}</a></li>
				{/each}
			{/await}
		</ul>
	</div>
</section>

<style lang="postcss">
	dt {
		&::after {
			content: ': ';
		}
		@apply font-bold;
	}
</style>
